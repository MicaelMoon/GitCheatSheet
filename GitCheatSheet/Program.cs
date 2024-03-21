namespace GitCheatSheet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> commands = new List<string>();

            commands.Add("git init");
            commands.Add("git clone [repository URL]");
            commands.Add("git add [file(s)]");
            commands.Add("git commit -m \"[commit message]\"");
            commands.Add("git status");
            commands.Add("git diff");
            commands.Add("git diff --staged");
            commands.Add("git reset [file(s)]");
            commands.Add("git checkout -- [file(s)]");
            commands.Add("git branch");
            commands.Add("git branch [branch_name]");
            commands.Add("git checkout [branch_name]");
            commands.Add("git merge [branch_name]");
            commands.Add("git remote");
            commands.Add("git remote add [name] [URL]");
            commands.Add("git fetch [remote]");
            commands.Add("git pull [remote] [branch]");
            commands.Add("git push [remote] [branch]");
        }
    }
}
