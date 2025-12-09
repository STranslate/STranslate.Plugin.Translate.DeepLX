using CommunityToolkit.Mvvm.ComponentModel;

namespace STranslate.Plugin.Translate.DeepLX.ViewModel;

public partial class SettingsViewModel(IPluginContext context, Settings settings) : ObservableObject
{
    [ObservableProperty] public partial string Url { get; set; } = settings.Url;
    [ObservableProperty] public partial string Token { get; set; } = settings.Token;

    partial void OnUrlChanged(string value)
    {
        settings.Url = value;
        context.SaveSettingStorage<Settings>();
    }

    partial void OnTokenChanged(string value)
    {
        settings.Token = value;
        context.SaveSettingStorage<Settings>();
    }
}
