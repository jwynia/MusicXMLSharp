/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="frame-note")]
public partial class FrameNote {
    
    private @string stringField;
    
    private Fret fretField;
    
    private Fingering fingeringField;
    
    private Barre barreField;
    
    /// <remarks/>
    public @string @string {
        get {
            return this.stringField;
        }
        set {
            this.stringField = value;
        }
    }
    
    /// <remarks/>
    public Fret fret {
        get {
            return this.fretField;
        }
        set {
            this.fretField = value;
        }
    }
    
    /// <remarks/>
    public Fingering fingering {
        get {
            return this.fingeringField;
        }
        set {
            this.fingeringField = value;
        }
    }
    
    /// <remarks/>
    public Barre barre {
        get {
            return this.barreField;
        }
        set {
            this.barreField = value;
        }
    }
}