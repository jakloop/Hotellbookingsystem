
# AI use

When I start projects like this i always try do reduce the use of AI to the minimum. 
This is because i believe that there is much valuable learning in solving problems through 'doing it yourself'.
In spite of this, i also see the value of AI in some situations. Especially when I want to discuss different solutions
to a problem, or when I don't grasp the problem completely.

This project is similar to a previous project, where I built a library system. In that project I used AI
as a help for finding solutions to problems in my code, discussions, making templates I could be inspired by.
Much of the code in this project is based on the code from that project. This drastically reduced the need for help in 
general. I was able to solve problems much faster, and do I through the exeperience of the previous project.

## AI statement
In THIS project I have used AI (chatgpt or riderAIChat) in the following tasks.
- Help with Email check

This was assisted through the use of the AI in IDE (Rider).
Code before:
if (GuestRegister.Contains(guest.Email))
throw new ArgumentException("Guest already registered");
GuestRegister.Add(guest);

Code after AI guidance:

    public void RegisterGuest(Guest guest)
    {
        if (GuestRegister.Any(g => g.Email == guest.Email))
        {
            throw new ArgumentException("Guest already registered");
        }
        GuestRegister.Add(guest);
    }



