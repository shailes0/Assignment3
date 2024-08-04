﻿using Assignment3;

public class Node
{
    public User Data { get; set; }
    public Node Next { get; set; }

    public Node(User data)
    {
        Data = data;
        Next = null;
    }
}
