using System.Threading.Channels;

namespace GitCheatSheet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> commands = new List<string>();

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
            commands.Add("potatis");
        }
    }
}
