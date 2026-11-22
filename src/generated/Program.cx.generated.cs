using Donkeh.Hosting;
using Donkeh.UILab;
using Components;

namespace DonkehCSXTest;

[AppRoot(Width = 1000, Height = 700, Title = "DonkehCSXTest")]
public sealed class App : Component
{
    /// <inheritdoc/>
    public override Node Render() =>
        _.C<Header>();
}