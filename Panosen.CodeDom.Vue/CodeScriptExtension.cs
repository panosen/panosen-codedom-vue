using Panosen.CodeDom;
using Panosen.CodeDom.JavaScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Vue
{
    /// <summary>
    /// CodeScript Extension
    /// </summary>
    public static class CodeScriptExtension
    {
        /// <summary>
        /// SetName
        /// </summary>
        /// <param name="codeScript"></param>
        /// <param name="name"></param>
        public static void SetName(this CodeScript codeScript, string name)
        {
            codeScript.Name = name;
        }

        /// <summary>
        /// CodeScript.Imports
        /// </summary>
        /// <param name="codeScript"></param>
        /// <param name="key">示例：Layout</param>
        /// <param name="path">示例：savory-canos-vuetify-component/components/Layout.vue</param>
        public static void AddImport(this CodeScript codeScript, string key, string path)
        {
            if (codeScript.Imports == null)
            {
                codeScript.Imports = new Dictionary<string, string>();
            }

            codeScript.Imports.Add(key, path);
        }
        /// <summary>
        /// CodeScript.Components
        /// </summary>
        /// <param name="codeScript"></param>
        /// <param name="key"></param>
        /// <param name="component"></param>
        public static void AddComponent(this CodeScript codeScript, string key, string component)
        {
            if (codeScript.Components == null)
            {
                codeScript.Components = new Dictionary<string, string>();
            }

            codeScript.Components.Add(key, component);
        }

        /// <summary>
        /// CodeScript.PropMap
        /// </summary>
        /// <param name="codeScript"></param>
        /// <param name="key"></param>
        /// <param name="prop"></param>
        public static void AddProp(this CodeScript codeScript, string key, VueProp prop)
        {
            if (codeScript.PropMap == null)
            {
                codeScript.PropMap = new Dictionary<string, VueProp>();
            }

            codeScript.PropMap.Add(key, prop);
        }

        /// <summary>
        /// CodeScript.PropMap
        /// </summary>
        /// <param name="codeScript"></param>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <param name="required"></param>
        public static void AddProp(this CodeScript codeScript, string key, string type, bool required = false)
        {
            if (codeScript.PropMap == null)
            {
                codeScript.PropMap = new Dictionary<string, VueProp>();
            }

            VueProp prop = new VueProp();
            prop.Type = type;
            prop.Required = required;

            codeScript.PropMap.Add(key, prop);
        }

        /// <summary>
        /// CodeScript.DataObject.DataValueMap
        /// </summary>
        public static void AddDataValue(this CodeScript codeScript, string key, DataValue dataValue)
        {
            if (codeScript.DataObject == null)
            {
                codeScript.DataObject = new SortedDataObject();
            }

            codeScript.DataObject.AddDataValue(key, dataValue);
        }

        /// <summary>
        /// CodeScript.DataObject.DataValueMap
        /// </summary>
        public static DataValue AddDataValue(this CodeScript codeScript, string key)
        {
            if (codeScript.DataObject == null)
            {
                codeScript.DataObject = new SortedDataObject();
            }

            return codeScript.DataObject.AddDataValue(key);
        }

        /// <summary>
        /// CodeScript.DataObject.DataObjectMap
        /// </summary>
        public static void AddDataObject(this CodeScript codeScript, string key, DataObject dataObject)
        {
            if (codeScript.DataObject == null)
            {
                codeScript.DataObject = new SortedDataObject();
            }

            codeScript.DataObject.AddDataObject(key, dataObject);
        }

        /// <summary>
        /// CodeScript.DataObject.DataObjectMap
        /// </summary>
        public static DataObject AddDataObject(this CodeScript codeScript, string key)
        {
            if (codeScript.DataObject == null)
            {
                codeScript.DataObject = new SortedDataObject();
            }

            return codeScript.DataObject.AddDataObject(key);
        }

        /// <summary>
        /// CodeScript.DataObject.DataObjectMap
        /// </summary>
        public static void AddSortedDataObject(this CodeScript codeScript, string key, SortedDataObject sortedDataObject)
        {
            if (codeScript.DataObject == null)
            {
                codeScript.DataObject = new SortedDataObject();
            }

            codeScript.DataObject.AddSortedDataObject(key, sortedDataObject);
        }

        /// <summary>
        /// CodeScript.DataObject.DataObjectMap
        /// </summary>
        public static SortedDataObject AddSortedDataObject(this CodeScript codeScript, string key)
        {
            if (codeScript.DataObject == null)
            {
                codeScript.DataObject = new SortedDataObject();
            }

            return codeScript.DataObject.AddSortedDataObject(key);
        }

        /// <summary>
        /// CodeScript.DataObject.DataArrayMap
        /// </summary>
        public static void AddDataArray(this CodeScript codeScript, string key, DataArray dataArray)
        {
            if (codeScript.DataObject == null)
            {
                codeScript.DataObject = new SortedDataObject();
            }

            codeScript.DataObject.AddDataArray(key, dataArray);
        }

        /// <summary>
        /// CodeScript.DataObject.DataArrayMap
        /// </summary>
        public static DataArray AddDataArray(this CodeScript codeScript, string key)
        {
            if (codeScript.DataObject == null)
            {
                codeScript.DataObject = new SortedDataObject();
            }

            return codeScript.DataObject.AddDataArray(key);
        }

        /// <summary>
        /// AddWatch
        /// </summary>
        /// <param name="codeScript"></param>
        /// <param name="key"></param>
        /// <param name="codeMethod"></param>
        /// <returns></returns>
        public static CodeScript AddWatch(this CodeScript codeScript, string key, CodeMethod codeMethod)
        {
            if (codeScript.Watches == null)
            {
                codeScript.Watches = new Dictionary<string, CodeMethod>();
            }

            codeScript.Watches.Add(key, codeMethod);

            return codeScript;
        }

        /// <summary>
        /// AddWatch
        /// </summary>
        /// <param name="codeScript"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static CodeMethod AddWatch(this CodeScript codeScript, string key)
        {
            if (codeScript.Watches == null)
            {
                codeScript.Watches = new Dictionary<string, CodeMethod>();
            }

            CodeMethod codeMethod = new CodeMethod();

            codeScript.Watches.Add(key, codeMethod);

            return codeMethod;
        }

        /// <summary>
        /// AddComputed
        /// </summary>
        /// <param name="codeScript"></param>
        /// <param name="key"></param>
        /// <param name="codeMethod"></param>
        /// <returns></returns>
        public static CodeScript AddComputed(this CodeScript codeScript, string key, CodeMethod codeMethod)
        {
            if (codeScript.Computeds == null)
            {
                codeScript.Computeds = new Dictionary<string, CodeMethod>();
            }

            codeScript.Computeds.Add(key, codeMethod);

            return codeScript;
        }

        /// <summary>
        /// AddComputed
        /// </summary>
        /// <param name="codeScript"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static CodeMethod AddComputed(this CodeScript codeScript, string key)
        {
            if (codeScript.Computeds == null)
            {
                codeScript.Computeds = new Dictionary<string, CodeMethod>();
            }

            CodeMethod codeMethod = new CodeMethod();

            codeScript.Computeds.Add(key, codeMethod);

            return codeMethod;
        }

        /// <summary>
        /// AddMounted
        /// </summary>
        public static CodeScript AddMounted(this CodeScript codeScript, CodeMethod codeMethod)
        {
            codeScript.Mounted = codeMethod;

            return codeScript;
        }

        /// <summary>
        /// AddMounted
        /// </summary>
        public static CodeMethod AddMounted(this CodeScript codeScript)
        {
            CodeMethod codeMethod = new CodeMethod();
            codeScript.Mounted = codeMethod;

            return codeMethod;
        }

        /// <summary>
        /// AddMounted
        /// </summary>
        public static CodeScript AddCreated(this CodeScript codeScript, CodeMethod codeMethod)
        {
            codeScript.Created = codeMethod;

            return codeScript;
        }

        /// <summary>
        /// AddMounted
        /// </summary>
        public static CodeMethod AddCreated(this CodeScript codeScript)
        {
            CodeMethod codeMethod = new CodeMethod();
            codeScript.Created = codeMethod;

            return codeMethod;
        }

        /// <summary>
        /// AddMethod
        /// </summary>
        /// <param name="codeScript"></param>
        /// <param name="key"></param>
        /// <param name="codeMethod"></param>
        /// <returns></returns>
        public static CodeScript AddMethod(this CodeScript codeScript, string key, CodeMethod codeMethod)
        {
            if (codeScript.Methods == null)
            {
                codeScript.Methods = new Dictionary<string, CodeMethod>();
            }

            codeScript.Methods.Add(key, codeMethod);

            return codeScript;
        }

        /// <summary>
        /// AddMethod
        /// </summary>
        /// <param name="codeScript"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static CodeMethod AddMethod(this CodeScript codeScript, string key)
        {
            if (codeScript.Methods == null)
            {
                codeScript.Methods = new Dictionary<string, CodeMethod>();
            }

            CodeMethod codeMethod = new CodeMethod();

            codeScript.Methods.Add(key, codeMethod);

            return codeMethod;
        }
    }
}
