using Volo.Abp.Settings;

namespace newsApp.Settings;

public class newsAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(newsAppSettings.MySetting1));
    }
}
