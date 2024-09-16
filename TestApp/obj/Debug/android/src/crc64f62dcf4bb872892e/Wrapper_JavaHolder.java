package crc64f62dcf4bb872892e;


public class Wrapper_JavaHolder
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("TestApp.Utils.Wrapper+JavaHolder, TestApp", Wrapper_JavaHolder.class, __md_methods);
	}


	public Wrapper_JavaHolder ()
	{
		super ();
		if (getClass () == Wrapper_JavaHolder.class) {
			mono.android.TypeManager.Activate ("TestApp.Utils.Wrapper+JavaHolder, TestApp", "", this, new java.lang.Object[] {  });
		}
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
