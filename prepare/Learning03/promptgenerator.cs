using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<String> _prompts = new List<string>()
    {
        "What made me happy today?",
        "What challenge did I face?",
        "Who inspired me today?",
        "What am I grateful for?",
        "What did I learn today?"
    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index =random.Next(_prompts.Count);
        return _prompts[index];
    }

}