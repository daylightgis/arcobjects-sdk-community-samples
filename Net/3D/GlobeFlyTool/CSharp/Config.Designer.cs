//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GlobeFlyTool {
    using ESRI.ArcGIS.Desktop.AddIns;
    using ESRI.ArcGIS.Framework;
    using ESRI.ArcGIS.ArcGlobe;
    using ESRI.ArcGIS.Analyst3D;
    using ESRI.ArcGIS.GlobeCore;
    using System;
    using System.Collections.Generic;
    
    
    /// <summary>
    /// A class for looking up declarative information in the associated configuration xml file (.esriaddinx).
    /// </summary>
    internal static class ThisAddIn {
        
        internal static string Name {
            get {
                return "GlobeFlyTool";
            }
        }
        
        internal static string AddInID {
            get {
                return "{1e3ebb07-38d1-4ce2-92e7-9f26adaf9ee8}";
            }
        }
        
        internal static string Company {
            get {
                return "ESRI";
            }
        }
        
        internal static string Version {
            get {
                return "1.0";
            }
        }
        
        internal static string Description {
            get {
                return "This add-in sample shows how to create a Fly tool for ArcGlobe. This sample mimic" +
                    "s the out-of-the-box Fly tool for ArcGlobe. The developers can use this sample a" +
                    "s a starting point to customize the Fly tool according to their needs.";
            }
        }
        
        internal static string Author {
            get {
                return "ESRI";
            }
        }
        
        internal static string Date {
            get {
                return "12/10/2009";
            }
        }
        
        internal static ESRI.ArcGIS.esriSystem.UID ToUID(this System.String id) {
            ESRI.ArcGIS.esriSystem.UID uid = new ESRI.ArcGIS.esriSystem.UIDClass();
            uid.Value = id;
            return uid;
        }
        
        /// <summary>
        /// A class for looking up Add-in id strings declared in the associated configuration xml file (.esriaddinx).
        /// </summary>
        internal class IDs {
            
            /// <summary>
            /// Returns 'ESRI_GlobeFlyTool_Fly', the id declared for Add-in Tool class 'Fly'
            /// </summary>
            internal static string Fly {
                get {
                    return "ESRI_GlobeFlyTool_Fly";
                }
            }
        }
    }
    
internal static class ArcGlobe
{
  private static IApplication s_app;
  private static IGMxDocumentEvents_Event s_docEvent;

  public static IApplication Application
  {
    get
    {
      if (s_app == null)
        s_app = Internal.AddInStartupObject.GetHook<IGMxApplication>() as IApplication;
      return s_app;
    }
  }

  public static IGMxDocument Document
  {
    get
    {
      if (Application != null)
        return Application.Document as IGMxDocument;

      return null;
    }
  }
  
  public static IGMxApplication ThisApplication
  {
    get { return Application as IGMxApplication; }
  }
  
  public static IDockableWindowManager DockableWindowManager
  {
    get { return Application as IDockableWindowManager; }
  }
  
  public static IGMxDocumentEvents_Event Events
  {
    get
    {
      s_docEvent = Document as IGMxDocumentEvents_Event;
      return s_docEvent;
    }
  }

  public static IGlobe Globe
  {
    get
    {
      IGMxDocument doc = Document;
      if (doc != null)
        return doc.Scene as IGlobe;

      return null;
    }
  }
}

namespace Internal
{
  [StartupObjectAttribute()]
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  public sealed partial class AddInStartupObject : AddInEntryPoint
  {
    private static AddInStartupObject _sAddInHostManager;
    private List<object> m_addinHooks = null;

    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public AddInStartupObject()
    {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    protected override bool Initialize(object hook)
    {
      bool createSingleton = _sAddInHostManager == null;
      if (createSingleton)
      {
        _sAddInHostManager = this;
        m_addinHooks = new List<object>();
        m_addinHooks.Add(hook);
      }
      else if (!_sAddInHostManager.m_addinHooks.Contains(hook))
        _sAddInHostManager.m_addinHooks.Add(hook);

      return createSingleton;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    protected override void Shutdown()
    {
      _sAddInHostManager = null;
      m_addinHooks = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal static T GetHook<T>() where T : class
    {
      if (_sAddInHostManager != null)
      {
        foreach (object o in _sAddInHostManager.m_addinHooks)
        {
          if (o is T)
            return o as T;
        }
      }

      return null;
    }

    // Expose this instance of Add-in class externally
    public static AddInStartupObject GetThis()
    {
      return _sAddInHostManager;
    }
  }
}
}
