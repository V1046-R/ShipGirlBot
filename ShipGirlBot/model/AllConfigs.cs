using System.Collections.Generic;
internal class AllConfigs : BasicResponse
{
    public GameGlobalConfig globalConfig = null;
    public MarketingConfig marketingConfigs = null;
    public PVEExploreLevelConfig[] pveExplore = null;
    public ShipConfig[] shipCard = null;
    public EquipmentConfig[] shipEquipmnt = null;
    public ShipEvoItemConfig[] shipItem = null;

    public SkillConfig[] shipSkil1 = null;
    public BuffConfig[] shipSkillBuff = null;
    public Dictionary<string, string> errorCode = new Dictionary<string, string>();

}

