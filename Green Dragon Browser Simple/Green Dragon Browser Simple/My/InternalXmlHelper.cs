// Decompiled with JetBrains decompiler
// Type: Green_Dragon_Browser.My.InternalXmlHelper
// Assembly: Green Dragon Browser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=d25b577927d337c7
// MVID: 43B6EF03-694B-4A1E-BE9F-3F26039BA1DF
// Assembly location: C:\Users\emils_000\Desktop\Green Dragon\Green Dragon Browser\Green Dragon Browser Simple.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Green_Dragon_Browser.My
{
  [DebuggerNonUserCode]
  [EditorBrowsable(EditorBrowsableState.Never)]
  [CompilerGenerated]
  internal sealed class InternalXmlHelper
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    private InternalXmlHelper()
    {
    }

    public static string get_Value(IEnumerable<XElement> source)
    {
      IEnumerator<XElement> enumerator;
      try
      {
        enumerator = source.GetEnumerator();
        if (enumerator.MoveNext())
          return enumerator.Current.Value;
      }
      finally
      {
        if (enumerator != null)
          enumerator.Dispose();
      }
      return (string) null;
    }

    public static void set_Value(IEnumerable<XElement> source, string value)
    {
      IEnumerator<XElement> enumerator;
      try
      {
        enumerator = source.GetEnumerator();
        if (!enumerator.MoveNext())
          return;
        enumerator.Current.Value = value;
      }
      finally
      {
        if (enumerator != null)
          enumerator.Dispose();
      }
    }

    public static string get_AttributeValue(IEnumerable<XElement> source, XName name)
    {
      IEnumerator<XElement> enumerator;
      try
      {
        enumerator = source.GetEnumerator();
        if (enumerator.MoveNext())
          return (string) enumerator.Current.Attribute(name);
      }
      finally
      {
        if (enumerator != null)
          enumerator.Dispose();
      }
      return (string) null;
    }

    public static void set_AttributeValue(IEnumerable<XElement> source, XName name, string value)
    {
      IEnumerator<XElement> enumerator;
      try
      {
        enumerator = source.GetEnumerator();
        if (!enumerator.MoveNext())
          return;
        enumerator.Current.SetAttributeValue(name, (object) value);
      }
      finally
      {
        if (enumerator != null)
          enumerator.Dispose();
      }
    }

    public static string get_AttributeValue(XElement source, XName name)
    {
      return (string) source.Attribute(name);
    }

    public static void set_AttributeValue(XElement source, XName name, string value)
    {
      source.SetAttributeValue(name, (object) value);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static XAttribute CreateAttribute(XName name, object value)
    {
      if (value == null)
        return (XAttribute) null;
      else
        return new XAttribute(name, RuntimeHelpers.GetObjectValue(value));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static XAttribute CreateNamespaceAttribute(XName name, XNamespace ns)
    {
      XAttribute xattribute = new XAttribute(name, (object) ns.NamespaceName);
      xattribute.AddAnnotation((object) ns);
      return xattribute;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static object RemoveNamespaceAttributes(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes, object obj)
    {
      if (obj != null)
      {
        XElement e = obj as XElement;
        if (e != null)
        {
          // ISSUE: reference to a compiler-generated method
          return (object) InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, e);
        }
        IEnumerable enumerable = obj as IEnumerable;
        if (enumerable != null)
        {
          // ISSUE: reference to a compiler-generated method
          return (object) InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, enumerable);
        }
      }
      return obj;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IEnumerable RemoveNamespaceAttributes(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes, IEnumerable obj)
    {
      if (obj == null)
        return obj;
      IEnumerable<XElement> source = obj as IEnumerable<XElement>;
      if (source != null)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        return (IEnumerable) Enumerable.Select<XElement, XElement>(source, new Func<XElement, XElement>(new InternalXmlHelper.RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessXElement));
      }
      else
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        return (IEnumerable) Enumerable.Select<object, object>(Enumerable.Cast<object>(obj), new Func<object, object>(new InternalXmlHelper.RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessObject));
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static XElement RemoveNamespaceAttributes(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes, XElement e)
    {
      if (e != null)
      {
        for (XAttribute xattribute1 = e.FirstAttribute; xattribute1 != null; {
          XAttribute nextAttribute;
          xattribute1 = nextAttribute;
        }
        )
        {
          nextAttribute = xattribute1.NextAttribute;
          if (xattribute1.IsNamespaceDeclaration)
          {
            XNamespace xnamespace1 = xattribute1.Annotation<XNamespace>();
            string localName1 = xattribute1.Name.LocalName;
            if (xnamespace1 != null)
            {
              if (inScopePrefixes != null && inScopeNs != null)
              {
                int num1 = checked (inScopePrefixes.Length - 1);
                int num2 = 0;
                int num3 = num1;
                int index = num2;
                while (index <= num3)
                {
                  string str = inScopePrefixes[index];
                  XNamespace xnamespace2 = inScopeNs[index];
                  if (localName1.Equals(str))
                  {
                    if (xnamespace1 == xnamespace2)
                      xattribute1.Remove();
                    xattribute1 = (XAttribute) null;
                    break;
                  }
                  else
                    checked { ++index; }
                }
              }
              if (xattribute1 != null)
              {
                if (attributes != null)
                {
                  int num1 = checked (attributes.Count - 1);
                  int num2 = 0;
                  int num3 = num1;
                  int index = num2;
                  while (index <= num3)
                  {
                    XAttribute xattribute2 = attributes[index];
                    string localName2 = xattribute2.Name.LocalName;
                    XNamespace xnamespace2 = xattribute2.Annotation<XNamespace>();
                    if (xnamespace2 != null && localName1.Equals(localName2))
                    {
                      if (xnamespace1 == xnamespace2)
                        xattribute1.Remove();
                      xattribute1 = (XAttribute) null;
                      break;
                    }
                    else
                      checked { ++index; }
                  }
                }
                if (xattribute1 != null)
                {
                  xattribute1.Remove();
                  attributes.Add(xattribute1);
                }
              }
            }
          }
        }
      }
      return e;
    }
  }
}
