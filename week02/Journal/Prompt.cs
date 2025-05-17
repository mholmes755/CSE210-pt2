using System;
using System.Collections.Generic;

public class Prompt{
    public List<string> _prompts = new List<string>();


    public string GenertatePrompts()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}