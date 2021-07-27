interface ISomeInterface
{
	void Call();
}
struct SomeStruct: ISomeInterface
{
	public void Call()
	{

	}
}
class SomeClass
{
	public void Run()
	{
		ISomeInterace someStruct = new SomeStruct();
		SomeMethod(someStruct);
	}

	public void SomeMethod(ISomeInterface @interface){
		@interface.Call();
	}
}