using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarNET.Extensions
{
    public static class ControlExtensions
    {
        /// <summary>
        /// Gets all children control from the current control.
        /// </summary>
        /// <param name="control"></param>
        /// <param name="recursive">Set to true to find all children recursively.</param>
        /// <returns></returns>
        public static IEnumerable<Control> GetChildren(this Control control, bool recursive = true)
        {
            var children = control.Controls.Cast<Control>();
            return recursive ? children.SelectMany(child => child.GetChildren().Concat(children)).Distinct() : children;
        }

        /// <summary>
        /// Gets all children controls with a specified type.
        /// </summary>
        /// <param name="control"></param>
        /// <param name="recursive">Set to true to find all children recursively.</param>
        /// <returns></returns>
        public static IEnumerable<T> GetChildren<T>(this Control control, bool recursive = true) where T : Control
        {
            return control.GetChildren(recursive).Where(c => c.GetType() == typeof(T)).Cast<T>();
        }
    }
}
