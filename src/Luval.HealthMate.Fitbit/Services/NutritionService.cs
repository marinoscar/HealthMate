using Luval.HealthMate.Fitbit.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Luval.HealthMate.Fitbit.Services
{
    public class NutritionService
    {
        private readonly FitbitClient _client;
        private readonly ILogger<NutritionService> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="NutritionService"/> class.
        /// </summary>
        /// <param name="client">The Fitbit client.</param>
        /// <param name="logger">The logger instance.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="client"/> or <paramref name="logger"/> is null.
        /// </exception>
        public NutritionService(FitbitClient client, ILogger<NutritionService> logger)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Creates a new food item asynchronously.
        /// </summary>
        /// <param name="name">The name of the food.</param>
        /// <param name="defaultFoodMeasurementUnitId">The default measurement unit ID.</param>
        /// <param name="defaultServingSize">The default serving size.</param>
        /// <param name="calories">The number of calories.</param>
        /// <param name="formType">The form type of the food.</param>
        /// <param name="description">The description of the food.</param>
        /// <param name="nutritionalValues">Optional nutritional values.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the created food response.</returns>
        /// <exception cref="ArgumentException">Thrown when a required parameter is null or empty.</exception>
        public async Task<CreateFoodResponse> CreateFoodAsync(
                string name,
                string defaultFoodMeasurementUnitId,
                string defaultServingSize,
                int calories,
                string formType,
                string description,
                NutritionalValues? nutritionalValues = null,
                CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Food name cannot be null or empty.", nameof(name));
            if (string.IsNullOrWhiteSpace(defaultFoodMeasurementUnitId)) throw new ArgumentException("Default food measurement unit ID cannot be null or empty.", nameof(defaultFoodMeasurementUnitId));
            if (string.IsNullOrWhiteSpace(defaultServingSize)) throw new ArgumentException("Default serving size cannot be null or empty.", nameof(defaultServingSize));
            if (calories < 0) throw new ArgumentException("Calories must be greater than zero.", nameof(calories));
            if (string.IsNullOrWhiteSpace(formType)) throw new ArgumentException("Form type cannot be null or empty.", nameof(formType));
            if (string.IsNullOrWhiteSpace(description)) throw new ArgumentException("Description cannot be null or empty.", nameof(description));

            var requestUri = "/1/user/-/foods.json";
            var parameters = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("name", name),
                    new KeyValuePair<string, string>("defaultFoodMeasurementUnitId", defaultFoodMeasurementUnitId),
                    new KeyValuePair<string, string>("defaultServingSize", defaultServingSize),
                    new KeyValuePair<string, string>("calories", Convert.ToString(calories)),
                    new KeyValuePair<string, string>("formType", formType),
                    new KeyValuePair<string, string>("description", description)
                };
            if (nutritionalValues != null)
                parameters.AddRange(nutritionalValues.CreateKeyValue());

            var content = new FormUrlEncodedContent(parameters);

            var request = new HttpRequestMessage(HttpMethod.Post, requestUri)
            {
                Content = content
            };

            try
            {
                var response = await _client.SendAsync(request, cancellationToken);
                var result = new CreateFoodResponse() { Response = response };
                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogWarning("Failed to create food. Status Code: {StatusCode}", response.StatusCode);
                    return result;
                }
                var json = await JsonSerializer.DeserializeAsync<JsonObject>(await response.Content.ReadAsStreamAsync(cancellationToken));
                if (json != null && json.Root["food"] != null)
                {
                    result.Food = JsonSerializer.Deserialize<Food>(Convert.ToString(json.Root["food"]));
                }
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while creating food.");
                throw;
            }
        }
    }
}
