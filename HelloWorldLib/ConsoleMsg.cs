namespace HellWorldLib
{
	public class ConsoleMsg : IMessage
	{
		string IMessage.OutputMessage() => "Hello World";
	}
}
