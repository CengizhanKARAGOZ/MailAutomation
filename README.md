# MailAutomation
Mail Automation in C#
This repository contains a C# console application for automating the process of sending emails. The application allows users to send an email with a subject, body, and optional attachment to a specified recipient. It is implemented using the System.Net.Mail library and supports SMTP configurations (e.g., Gmail).

## Features:
Dynamic Recipient Input: User can input the recipient's email address during runtime.
Customizable Content: Predefined subject and body that can be modified within the code.
Attachment Support: Ability to include a file attachment with the email.
SMTP Configuration: Configured to use Gmail's SMTP server with SSL encryption for secure mail delivery.
## Prerequisites:
Replace youremail@gmail.com and your-app-password with your email and app-specific password. Ensure you have enabled "App Passwords" or "Less Secure App Access" for Gmail.
Update the attachmentFilePath variable with the full path to your desired attachment file (or set it to null for no attachments).
## How to Run:
Clone the repository.
Open the project in your preferred C# IDE (e.g., Visual Studio).
Update the senderEmail, senderPassword, and attachmentFilePath variables with appropriate values.
Build and run the application.
Input the recipient's email address when prompted.
## Disclaimer:
This application is a basic implementation for learning purposes. Avoid hardcoding sensitive information in production environments.
Make sure to comply with your email provider's security policies and best practices for safe usage.
