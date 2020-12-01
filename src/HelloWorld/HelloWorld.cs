using System;
using System.Management.Automation;

namespace HelloWorld
{
    [Cmdlet(VerbsCommon.Get, "Greetings")]
    public class MyClass : PSCmdlet
    {
        [Parameter(ValueFromPipeline = true)]
        public string Name { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            var name = string.IsNullOrEmpty(Name) ? "World" : Name;
            var greetings = "Hello" + name;
            WriteObject(greetings);
        }
    }
}
