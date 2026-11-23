using Donkeh.UILab;

[assembly: Stylesheet("src/Components/Header/Header.css")]

namespace Components
{
    public class HeaderProps : Props
    {

    }
    public class Header : Component<HeaderProps>
    {
        public override Node Render()
        {
            return (
                _.H("header", new() { className = "header" }, _.H("h1", new() { }, "My Application"))   
            );
        }

    }
}