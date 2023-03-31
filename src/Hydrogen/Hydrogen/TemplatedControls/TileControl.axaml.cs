using Avalonia;
using Avalonia.Controls.Primitives;
using Avalonia.Media;

namespace Hydrogen.TemplatedControls;

public sealed class TileControl : TemplatedControl
{
    #region Template Properties
    public static readonly StyledProperty<double> TileSizeProperty = AvaloniaProperty.Register<TileControl, double>(
        nameof(TileSize), 40);

    public double TileSize
    {
        get => GetValue(TileSizeProperty);
        set => SetValue(TileSizeProperty, value);
    }

    public static readonly StyledProperty<SolidColorBrush> BackgroundLayerBrushProperty =
        AvaloniaProperty.Register<TileControl, SolidColorBrush>(nameof(BackgroundLayerBrush), new SolidColorBrush(Colors.Green));

    public SolidColorBrush BackgroundLayerBrush
    {
        get => GetValue(BackgroundLayerBrushProperty);
        set => SetValue(BackgroundLayerBrushProperty, value);
    }
    
    public static readonly StyledProperty<string> ActorGlyphProperty = AvaloniaProperty.Register<TileControl, string>(
        nameof(ActorGlyph), "@");

    public string ActorGlyph
    {
        get => GetValue(ActorGlyphProperty);
        set => SetValue(ActorGlyphProperty, value);
    }

    public static readonly StyledProperty<SolidColorBrush> ActorBrushProperty =
        AvaloniaProperty.Register<TileControl, SolidColorBrush>(
            nameof(ActorBrush), new SolidColorBrush(Colors.Magenta));

    public SolidColorBrush ActorBrush
    {
        get => GetValue(ActorBrushProperty);
        set => SetValue(ActorBrushProperty, value);
    }

    public static readonly StyledProperty<SolidColorBrush> ForegroundLayerBrushProperty = AvaloniaProperty.Register<TileControl, SolidColorBrush>(
        nameof(ForegroundLayerBrush), new SolidColorBrush(Colors.Red));

    public SolidColorBrush ForegroundLayerBrush
    {
        get => GetValue(ForegroundLayerBrushProperty);
        set => SetValue(ForegroundLayerBrushProperty, value);
    }

    public static readonly StyledProperty<float> ForegroundOpacityProperty = AvaloniaProperty.Register<TileControl, float>(
        nameof(ForegroundOpacity), 0.0f);

    public float ForegroundOpacity
    {
        get => GetValue(ForegroundOpacityProperty);
        set => SetValue(ForegroundOpacityProperty, value);
    }
    #endregion
}