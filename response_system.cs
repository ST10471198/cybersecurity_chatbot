using System;
using System.Collections.Generic;

namespace cybersecurity_awareness_chatbot
{//start of namespace
    public class response_system
    {//start of class

        private string username = string.Empty;

        public response_system(string userName)
        {//start of constructor
            username = userName;
            start_conversation();
        }//end of constructor

        private void start_conversation()
        {//start of start_conversation method

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("RUBY: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("I'm ready to answer your cybersecurity questions, " + username + "!");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("You can ask me about passwords, phishing, or safe browsing.");
            Console.WriteLine("Type 'exit' or 'quit' to end the conversation.\n");
            Console.ResetColor();

            string userInput;

            do
            {//start of do-while loop

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("User: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                userInput = Console.ReadLine();

                if (userInput != null && (userInput.ToLower() == "exit" || userInput.ToLower() == "quit"))
                {//start of exit check
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("RUBY: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Goodbye " + username + "! Stay safe online!");
                    Console.ResetColor();
                    break;
                }//end of exit check

                string response = get_response(userInput);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("RUBY: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(response);
                Console.ResetColor();
                Console.WriteLine();

            } while (true);//end of do-while loop

        }//end of start_conversation method

        private string[] split_user_input(string userInput)
        {//start of split_user_input method

            if (string.IsNullOrWhiteSpace(userInput))
            {//start of if statement
                return new string[0];
            }//end of if statement

            string trimmedInput = userInput.Trim();

            string[] words = trimmedInput.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '-' },
                                                  StringSplitOptions.RemoveEmptyEntries);

            return words;

        }//end of split_user_input method

        private int count_words_in_input(string userInput)
        {//start of count_words_in_input method

            string[] words = split_user_input(userInput);
            return words.Length;

        }//end of count_words_in_input method

        private void display_split_words(string userInput)
        {//start of display_split_words method

            string[] words = split_user_input(userInput);

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("[Debug - Split words: ");

            for (int i = 0; i < words.Length; i++)
            {//start of for loop
                Console.Write("'" + words[i] + "'");
                if (i < words.Length - 1)
                {//start of if statement
                    Console.Write(", ");
                }//end of if statement
            }//end of for loop

            Console.WriteLine("] (Total: " + words.Length + " words)");
            Console.ResetColor();

        }//end of display_split_words method

        private bool contains_word(string userInput, string targetWord)
        {//start of contains_word method

            string[] words = split_user_input(userInput);

            foreach (string word in words)
            {//start of foreach loop
                if (word.ToLower() == targetWord.ToLower())
                {//start of if statement
                    return true;
                }//end of if statement
            }//end of foreach loop

            return false;

        }//end of contains_word method

        private string get_first_word(string userInput)
        {//start of get_first_word method

            string[] words = split_user_input(userInput);

            if (words.Length > 0)
            {//start of if statement
                return words[0];
            }//end of if statement

            return string.Empty;

        }//end of get_first_word method

        private string extract_main_topic(string userInput)
        {//start of extract_main_topic method

            string[] words = split_user_input(userInput);

            string[] topics = { "password", "phishing", "browsing", "scam", "email", "website", "secure" };

            foreach (string word in words)
            {//start of foreach loop

                string lowerWord = word.ToLower();

                foreach (string topic in topics)
                {//start of inner foreach loop

                    if (lowerWord.Contains(topic))
                    {//start of if statement
                        return topic;
                    }//end of if statement

                }//end of inner foreach loop

            }//end of foreach loop

            return "unknown";

        }//end of extract_main_topic method

        private string get_response(string userInput)
        {//start of get_response method

            if (string.IsNullOrWhiteSpace(userInput))
            {//start of empty check
                return "I didn't catch that. Could you please type a question?";
            }//end of empty check

            display_split_words(userInput);

            int wordCount = count_words_in_input(userInput);

            string mainTopic = extract_main_topic(userInput);

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("[Debug - Word count: " + wordCount + " | Main topic: " + mainTopic + "]");
            Console.ResetColor();

            string lowerInput = userInput.ToLower().Trim();

            if (lowerInput.Contains("how are you") ||
                lowerInput.Contains("how are u") ||
                lowerInput.Contains("how you doing") ||
                lowerInput.Contains("how's it going"))
            {//start of how are you check
                return get_how_are_you_response();
            }//end of how are you check

            if (lowerInput.Contains("purpose") ||
                lowerInput.Contains("what do you do") ||
                lowerInput.Contains("why do you exist") ||
                lowerInput.Contains("what's your job") ||
                lowerInput.Contains("what is your function"))
            {//start of purpose check
                return get_purpose_response();
            }//end of purpose check

            if (lowerInput.Contains("what can i ask") ||
                lowerInput.Contains("what topics") ||
                lowerInput.Contains("what do you know") ||
                lowerInput.Contains("what can you help with") ||
                lowerInput.Contains("what should i ask"))
            {//start of topics check
                return get_topics_response();
            }//end of topics check

            if (contains_word(userInput, "password") || contains_word(userInput, "passphrase"))
            {//start of password check using split
                return get_password_safety_response();
            }//end of password check using split

            if (lowerInput.Contains("password") ||
                lowerInput.Contains("passphrase") ||
                lowerInput.Contains("secure password") ||
                lowerInput.Contains("strong password") ||
                lowerInput.Contains("password safety") ||
                lowerInput.Contains("password tips"))
            {//start of password check
                return get_password_safety_response();
            }//end of password check

            if (contains_word(userInput, "phishing") || contains_word(userInput, "scam"))
            {//start of phishing check using split
                return get_phishing_response();
            }//end of phishing check using split

            if (lowerInput.Contains("phishing") ||
                lowerInput.Contains("scam") ||
                lowerInput.Contains("fake email") ||
                lowerInput.Contains("suspicious email") ||
                lowerInput.Contains("email scam") ||
                lowerInput.Contains("phishing email"))
            {//start of phishing check
                return get_phishing_response();
            }//end of phishing check

            if (contains_word(userInput, "browsing") || contains_word(userInput, "browse"))
            {//start of browsing check using split
                return get_safe_browsing_response();
            }//end of browsing check using split

            if (lowerInput.Contains("browsing") ||
                lowerInput.Contains("browse") ||
                lowerInput.Contains("website safety") ||
                lowerInput.Contains("safe website") ||
                lowerInput.Contains("secure browsing") ||
                lowerInput.Contains("browser safety") ||
                lowerInput.Contains("safe browsing"))
            {//start of browsing check
                return get_safe_browsing_response();
            }//end of browsing check

            if (wordCount <= 3)
            {//start of short question check
                string firstWord = get_first_word(userInput);
                if (firstWord.ToLower() == "help")
                {//start of help check
                    return get_topics_response();
                }//end of help check
            }//end of short question check

            return get_default_response();

        }//end of get_response method

        private string get_how_are_you_response()
        {//start of get_how_are_you_response
            return "I'm just code, but I'm fully operational and ready to help you stay safe online! " +
                   "How can I assist you with cybersecurity today, " + username + "?";
        }//end of get_how_are_you_response

        private string get_purpose_response()
        {//start of get_purpose_response
            return "I educate South Africans about cyber threats! " +
                   "With cyberattacks increasing in our country, " +
                   "I'm here to help you recognize and avoid online dangers like phishing, " +
                   "weak passwords, and unsafe websites. Think of me as your personal cybersecurity assistant!";
        }//end of get_purpose_response

        private string get_topics_response()
        {//start of get_topics_response
            return "You can ask me about passwords, phishing, or safe browsing.\n\n" +
                   "For example:\n" +
                   "  - 'How do I create a strong password?'\n" +
                   "  - 'What is a phishing email?'\n" +
                   "  - 'How can I browse safely?'\n\n" +
                   "Just type your question and I'll help you out!";
        }//end of get_topics_response

        private string get_password_safety_response()
        {//start of get_password_safety_response
            return "PASSWORD SAFETY TIPS:\n\n" +
                   "- Use at least 12 characters\n" +
                   "- Mix uppercase and lowercase letters\n" +
                   "- Include numbers and symbols (!@#$%)\n" +
                   "- Don't use personal info (birthdays, names)\n" +
                   "- Never reuse passwords across different accounts\n" +
                   "- Consider using a password manager\n\n" +
                   "Remember: A strong password is your first defense against hackers!";
        }//end of get_password_safety_response

        private string get_phishing_response()
        {//start of get_phishing_response
            return "SPOTTING PHISHING EMAILS:\n\n" +
                   "Red flags to watch for:\n" +
                   "  - Urgent or threatening language ('Act now or account closed!')\n" +
                   "  - Spelling and grammar mistakes\n" +
                   "  - Suspicious sender email addresses\n" +
                   "  - Requests for personal information (passwords, credit cards)\n" +
                   "  - Unexpected attachments or links\n\n" +
                   "NEVER click links in suspicious emails! " +
                   "Contact the company directly using official channels.";
        }//end of get_phishing_response

        private string get_safe_browsing_response()
        {//start of get_safe_browsing_response
            return "SAFE BROWSING HABITS:\n\n" +
                   "- Look for 'https://' and padlock icon in the address bar\n" +
                   "- Keep your browser updated to the latest version\n" +
                   "- Use ad-blockers and anti-tracking tools\n" +
                   "- Never save passwords on public or shared computers\n" +
                   "- Clear your cache and cookies regularly\n" +
                   "- Be cautious of what you download\n\n" +
                   "Always verify website legitimacy before entering personal information!";
        }//end of get_safe_browsing_response

        private string get_default_response()
        {//start of get_default_response
            return "I didn't quite understand that. Could you rephrase?\n\n" +
                   "You can ask me about:\n" +
                   "  - Password safety\n" +
                   "  - Phishing emails\n" +
                   "  - Safe browsing\n\n" +
                   "Or try questions like:\n" +
                   "  - 'How are you?'\n" +
                   "  - 'What's your purpose?'\n" +
                   "  - 'What can I ask you about?'";
        }//end of get_default_response

    }//end of class

}//end of namespace