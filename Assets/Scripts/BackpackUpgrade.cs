public class BackpackUpgrade : Upgrade
{
	public override void SuccessfulPurchase()
	{
		GameData.Instance.AdditionalInventory += 3;
		GameCanvas.Instance.GetScreen<TitlesUIScreen>(UIScreenType.TITLES).SetBackpackUpgrade();
	}
}