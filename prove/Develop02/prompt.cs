using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


    public class Prompt
    {
    
    private List<string> questions = new List<string>() 
   
   { "What was the most eventful part of your day?",
        "Did you go to work/school today or both if so how did that go?",
        "Did you do anything fun for yourself today?",
        "Are you making any progress with goals you have?",
        "Were you able to talk to your family today?",
        "Did you do any good deeds today for other people?"
        };

    
    
    public string GetRanQuestions()
    {

    
    Random ran_questions = new Random();
    int index = ran_questions.Next(questions.Count);
    return questions[index];
    
     }

} 