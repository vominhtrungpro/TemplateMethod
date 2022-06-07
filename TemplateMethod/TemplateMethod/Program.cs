// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        //Build build = new Build();
        BuildOnStaging build = new BuildOnStaging();
        Console.ReadKey();
    }

    class Build
    {
        public Build()
        {
            CompileCode();
            RunTests();
            DeployCode();
        }

        public virtual void CompileCode()
        {
            Console.WriteLine("Code is compile!");
        }
        public virtual void RunTests()
        {
            Console.WriteLine("Test ran successfully!");
        }
        public virtual void DeployCode()
        {
            Console.WriteLine("Deployed to QE server!");
        }
    }

    class BuildOnStaging : Build
    {
        
        public override void DeployCode()
        {
            Console.WriteLine("Deployed to Staging server!");
        }
    }

}
