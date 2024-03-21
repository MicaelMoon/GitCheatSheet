using System.Threading.Channels;
using System.Text.Json;

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
            commands.Add("git clean");
            commands.Add("git stash pop");
            commands.Add("git stash");
            commands.Add("git push--tags");
            commands.Add("git tag");
            commands.Add("git tag -a [tag_name] \"[tag_message]\"");
            commands.Add("git tag [tag name]");
            commands.Add("git show [commit hash]");
            commands.Add("git log--author=[author]");
            commands.Add("git log--grep=[pattern]");
            commands.Add("git fetch [remote]");
            commands.Add("git pull [remote] [branch]");
            commands.Add("git push [remote] [branch]");
            commands.Add("git log");
            commands.Add("git log --online");

            string gitCommands = JsonSerializer.Serialize(commands);
            string path = Path.Combine(AppContext.BaseDirectory, "Comands.json");
            File.WriteAllText(path, gitCommands);
        }
    }
}
