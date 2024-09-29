package mono.com.google.inject.spi;


public class ProvisionListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.inject.spi.ProvisionListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onProvision:(Lcom/google/inject/spi/ProvisionListener$ProvisionInvocation;)V:GetOnProvision_Lcom_google_inject_spi_ProvisionListener_ProvisionInvocation_Handler:Xamarin.Google.Inject.Spi.IProvisionListenerInvoker, Xamarin.Google.Inject.Guice\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Google.Inject.Spi.IProvisionListenerImplementor, Xamarin.Google.Inject.Guice", ProvisionListenerImplementor.class, __md_methods);
	}


	public ProvisionListenerImplementor ()
	{
		super ();
		if (getClass () == ProvisionListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Xamarin.Google.Inject.Spi.IProvisionListenerImplementor, Xamarin.Google.Inject.Guice", "", this, new java.lang.Object[] {  });
		}
	}


	public void onProvision (com.google.inject.spi.ProvisionListener.ProvisionInvocation p0)
	{
		n_onProvision (p0);
	}

	private native void n_onProvision (com.google.inject.spi.ProvisionListener.ProvisionInvocation p0);

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
