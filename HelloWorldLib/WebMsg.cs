namespace HellWorldLib
{
	public class WebMsg : IMessage
	{
		string IMessage.OutputMessage() => "<div>Hello World</div>";
	}
}
