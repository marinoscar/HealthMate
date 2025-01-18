# HealthMate

## Overview
HealthMate is a comprehensive health tracking application that leverages the power of Generative AI to offer personalized nutrition and fitness recommendations. The app integrates with the Fitbit Web API to track daily activities and uses advanced AI models to analyze food intake through pictures or labels. This data enables HealthMate to provide tailored advice to help users achieve their health goals.

## Features
- **Activity Tracking**: Connects with Fitbit to import your daily activity data including steps, heart rate, and sleep patterns.
- **Nutritional Analysis**: Uses AI to extract nutritional information from images of your meals or scanned food labels.
- **Personalized Recommendations**: Based on your activity and dietary inputs, receive AI-driven advice tailored to your personal health objectives.

## Technology Stack
- **Frontend**: Blazor WebAssembly
- **Backend**: ASP.NET Core
- **AI Services**: Utilizes custom trained models for image recognition and data extraction
- **APIs**: Fitbit Web API for fetching fitness data
- **Database**: SQL Server for data persistence

## Getting Started

### Prerequisites
- .NET 9.0
- Visual Studio 2022 or later
- Fitbit account for API access

### Setup
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/HealthMate.git
