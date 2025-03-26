# Lab Automation Control System

## Overview

The **Lab Automation Control System** is a desktop application built using **C#** and **WPF** designed to simulate the control and monitoring of lab automation devices. This system integrates with a mock **Lab Information Management System (LIMS)** and uses **MinIO**, a Dockerized AWS S3-compatible storage solution, to simulate cloud storage for test results and logs. The system is intended for healthcare and biotech applications, providing an interface for controlling devices, viewing test results, and storing data.

## Features

### 1. **Device Control Module**
   - Simulates control of various lab devices such as blood analyzers, incubators, and centrifuges.
   - Provides functionality for:
     - **Start**: Begin a test.
     - **Stop**: End a test.
     - **Pause**: Pause the ongoing test.
     - **Reset**: Reset the device.
   - Displays real-time device status updates (e.g., "Running", "Idle", "Error").
   - Tracks the progress of tests with visual feedback like progress bars.

### 2. **LIMS Integration Module**
   - Simulates the interaction with a Lab Information Management System (LIMS) to manage test results.
   - Implements **CRUD** operations (Create, Read, Update, Delete):
     - **Create**: Add new test results to the system.
     - **Read**: Retrieve test results based on criteria like Sample ID or Test ID.
     - **Update**: Modify test results or sample statuses.
     - **Delete**: Remove test results or sample records from the system.

### 3. **Cloud Storage Integration (MinIO)**
   - Integrates with **MinIO**, a Dockerized S3-compatible storage service, to store test results and logs.
   - Allows for file uploads, downloads, and deletions using AWS S3-compatible API.
   - Stores and retrieves test results in various formats (e.g., CSV, JSON).
   - Tracks file metadata (e.g., file name, upload date, file size).

### 4. **Real-Time Monitoring**
   - Provides a real-time dashboard to monitor lab devices and their ongoing tests.
   - Displays device status updates and progress bars.
   - Sends notifications in case of device malfunctions or test failures.

## Technologies

- **C#**: The primary programming language used for the backend logic.
- **WPF**: For building the desktop user interface using the **MVVM** (Model-View-ViewModel) design pattern.
- **MinIO**: A locally hosted, S3-compatible storage service running in Docker to simulate cloud storage.
- **Docker**: Used for containerizing MinIO to emulate AWS S3 for cloud-based storage.
- **AWS SDK for .NET**: Used for interacting with the MinIO cloud storage via the S3-compatible API.

## Setup Instructions

### 1. **Prerequisites**
   - **Docker**: Ensure Docker is installed and running on your machine. If you don't have Docker installed, follow the instructions [here](https://www.docker.com/get-started).
   - **Visual Studio**: Required for building and running the WPF application.

### 2. **Setting Up MinIO**
   - Clone the repository and navigate to the project directory.
   - Use the provided `docker-compose.yml` file to set up MinIO:
   
     ```bash
     docker-compose up -d
     ```
   - Access MinIO's web interface at `http://localhost:9000` using the credentials:
     - **Username**: `minioadmin`
     - **Password**: `minioadmin123`
   - MinIO will be ready to store and retrieve files.

### 3. **Building and Running the WPF Application**
   - Open the project in **Visual Studio**.
   - Build and run the project.
   - The application will start with a basic WPF interface where you can control lab devices, view test results, and interact with cloud storage.

### 4. **Running the Application**
   - The app will allow you to:
     - Control simulated lab devices (Start, Stop, Pause, Reset).
     - View test results stored in the mock LIMS system.
     - Upload and download test results from MinIO.
     - Monitor real-time device status and test progress.

## Architecture

The application follows the **MVVM (Model-View-ViewModel)** design pattern, which separates the user interface, business logic, and data. The core modules are:

- **Device Control**: Handles the simulation of lab devices and their interactions with the UI.
- **LIMS Integration**: Manages test results and sample data.
- **Cloud Storage (MinIO)**: Handles file storage and retrieval using the S3-compatible MinIO service.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

