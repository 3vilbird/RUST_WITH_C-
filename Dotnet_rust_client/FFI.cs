using System;

using System.Runtime.InteropServices;

namespace Dotnet_rust_client
{
    public static class API
    {

        [DllImport("demo", EntryPoint = "rust_add")]
        public static extern Int32 RustAdd(Int32 a, Int32 b);

    }
}
