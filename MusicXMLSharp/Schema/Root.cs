/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Root {
    
    private RootStep _rootStepField;
    
    private RootAlter _rootAlterField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("root-step")]
    public RootStep RootStep {
        get {
            return this._rootStepField;
        }
        set {
            this._rootStepField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("root-alter")]
    public RootAlter RootAlter {
        get {
            return this._rootAlterField;
        }
        set {
            this._rootAlterField = value;
        }
    }
}