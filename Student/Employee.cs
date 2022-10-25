﻿using System;
public class Employee
{
    public int id;
    public String name;
    public float salary;
    public void insert(int i, String n, float s)
    {
        id = i;
        name = n;
        salary = s;
    }
    public void display()
    {
        Console.WriteLine(id + " " + name + " " + salary);
    }
}
class TestEmployee
{
    public static void main (String[] args)
    {
        Employee e1 = new Employee();
        Employee e2 = new Employee();
        e1.insert(101, "Sonoo", 890000f);
        e2.insert(102, "Mahesh", 490000f);
        e1.display();
        e2.display();

    }
}