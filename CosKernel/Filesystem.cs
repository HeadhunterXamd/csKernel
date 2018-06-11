using System;
using System.IO;
using Cosmos.System.FileSystem;
using Sys = Cosmos.System;

namespace CosKernel
{
    public class Filesystem
    {
        private CosmosVFS _vfs;

        public Filesystem()
        {
            _vfs = new CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(_vfs);
        }

        /// <summary>
        /// Get all the files from the given directory.
        /// </summary>
        /// <param name="address">The path</param>
        /// <returns>a list of filenames.</returns>
        public string[] ListFiles(string address, string pattern = "", bool recursive = false)
        {
            // check if we want a recursive search
            var sopt = SearchOption.TopDirectoryOnly;
            if (recursive)
                sopt = SearchOption.AllDirectories;


            string[] files = new string[256];
            if (Directory.GetFiles(address).Length > 0)
                files = Directory.GetFiles(address, pattern, sopt);
            else
                files[0] = "No files found.";
            return files;
        }

        public string[] ListDirectories(string address)
        {
            return Directory.GetDirectories(address);
        }

        public string[] ReadLines(string fileAddress)
        {
            string[] fileRead = File.ReadAllLines(fileAddress);
            return fileRead;
        }

        public string ReadText(string fileAddress)
        {
            var fContents = File.ReadAllText(fileAddress);
            return fContents;
        }

        public byte[] ReadByte(string fileAddress)
        {
            byte[] fileRead = File.ReadAllBytes(fileAddress);
            return fileRead;
        }

    }
}
