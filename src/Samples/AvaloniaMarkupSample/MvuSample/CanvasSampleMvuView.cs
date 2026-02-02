using Avalonia.Controls.Shapes;

namespace AvaloniaMarkupSample.MvuSample;

public class CanvasSampleMvuView : ComponentBase
{
    protected override Control Build() =>
        new Grid().Rows("30, 40, *")
            .Children(

                new TextBlock().Text("Canvas Sample"),
                new Slider()
                    .Row(1)
                    .HorizontalAlignment(HorizontalAlignment.Left)
                    .MinWidth(300)
                    .Value(() => Offset, v => Offset = v),

                new Canvas()
                    .Row(2)
                    .Background(Brushes.LightCyan)
                    .Children(
                        new Ellipse().Fill(Brushes.DarkRed)
                            .Width(50)
                            .Height(50)
                            .Canvas_Left(Offset)
                            .Canvas_Top(Offset)
                        )
                );


    public double Offset { get; set; }
}
