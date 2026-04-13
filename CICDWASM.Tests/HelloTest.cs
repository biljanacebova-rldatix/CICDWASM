using Bunit;
using Xunit;
using CICDWASM.Pages;

namespace CICDWASM.Tests;

public class HelloTest : BunitContext
{
    [Fact]
    public void RendersDefaultName()
    {
         var cut = Render<CICDWASM.Pages.Hello>();

         cut.MarkupMatches("<h3>Hello World</h3>");
    }

    [Fact]
    public void RendersPassedParameter()
    {
        var cut = Render<Hello>(parameters =>
            parameters.Add(p => p.Name, "Alice"));

        cut.MarkupMatches("<h3>Hello Alice</h3>");
    }
}