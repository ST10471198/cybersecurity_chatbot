# Cybersecurity Awareness Chatbot - Part 1

## Project Overview

This is a command-line cybersecurity awareness chatbot developed for South African citizens as part of a national cybersecurity education campaign. The chatbot helps users learn about online safety practices including password safety, phishing awareness, and safe browsing habits.

## Features Implemented

### 1. Voice Greeting
- Plays a recorded voice greeting when the application launches
- Audio file format: WAV
- Friendly welcome message to engage users

### 2. ASCII Image Display
- Displays an ASCII art representation of a cybersecurity logo
- Acts as a header/title screen when the chatbot launches

### 3. Text-Based Greeting and User Interaction
- Asks users for their name
- Personalises responses using the user's name throughout the conversation
- Displays a text-based welcome message with decorative formatting

### 4. Basic Response System
The chatbot can respond to the following types of questions:
- "How are you?"
- "What's your purpose?"
- "What can I ask you about?"
- Password safety tips
- Phishing awareness and detection
- Safe browsing habits

### 5. Input Validation
- Handles empty inputs gracefully
- Provides default responses for unrecognised questions
- Displays help menu for unsupported queries

### 6. Enhanced Console UI
- Coloured text for better visual appeal
- Borders and dividers for structure
- Typing effect to simulate natural conversation
- Section headers for readability

### 7. Split Function Implementation
The chatbot uses a custom `split_user_input()` function that:
- Breaks user input into individual words
- Removes punctuation and extra spaces
- Enables accurate keyword detection
- Provides word count functionality
- Extracts main topics from user questions

### 8. Code Structure
- Clean separation of concerns across multiple classes
- Methods named with underscores for consistency
- Automatic properties where appropriate
- Well-commented code with `//start of` and `//end of` markers

## Project Structure
cybersecurity_awareness_chatbot/
├── Program.cs # Main entry point
├── Audio_greeting.cs # Voice greeting functionality
├── Ascii_Logo.cs # ASCII art display
├── Welcoming_User.cs # User greeting and name collection
├── response_system.cs # Main chatbot response logic
├── Voice_Recording.wav # Voice greeting audio file
├── logo.jpeg # Image for ASCII conversion
└── README.md # Project documentation


## Class Descriptions

| Class | Purpose |
|-------|---------|
| `Program` | Main entry point, creates instances of all classes |
| `Audio_greeting` | Plays the WAV audio greeting on startup |
| `Ascii_Logo` | Converts JPEG image to ASCII art and displays it |
| `Welcoming_User` | Greets user, asks for name, validates input |
| `response_system` | Handles conversation, processes user input, provides responses |

## Response System Methods

| Method | Description |
|--------|-------------|
| `split_user_input()` | Splits user input into an array of words using delimiters |
| `count_words_in_input()` | Returns the number of words in user input |
| `display_split_words()` | Shows split words for debugging purposes |
| `contains_word()` | Checks if a specific word exists in user input |
| `get_first_word()` | Returns the first word of user input |
| `extract_main_topic()` | Identifies the main cybersecurity topic |
| `get_response()` | Main method that processes input and returns appropriate response |


### Prerequisites
- Windows Operating System
- .NET Framework or .NET Core installed
- Visual Studio or any C# compatible IDE
