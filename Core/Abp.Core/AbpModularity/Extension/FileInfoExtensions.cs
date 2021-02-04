﻿using Abp.Core.AbpModularity.Helper;
using JetBrains.Annotations;
using Microsoft.Extensions.FileProviders;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Abp.Core.AbpModularity.Extension
{
    public static class FileInfoExtensions
    {
        /// <summary>
        /// Reads file content as string using <see cref="Encoding.UTF8"/> encoding.
        /// </summary>
        public static string ReadAsString([NotNull] this IFileInfo fileInfo)
        {
            return fileInfo.ReadAsString(Encoding.UTF8);
        }

        /// <summary>
        /// Reads file content as string using <see cref="Encoding.UTF8"/> encoding.
        /// </summary>
        public static Task<string> ReadAsStringAsync([NotNull] this IFileInfo fileInfo)
        {
            return fileInfo.ReadAsStringAsync(Encoding.UTF8);
        }

        /// <summary>
        /// Reads file content as string using the given <paramref name="encoding"/>.
        /// </summary>
        public static string ReadAsString([NotNull] this IFileInfo fileInfo, Encoding encoding)
        {
            Check.NotNull(fileInfo, nameof(fileInfo));

            using (var stream = fileInfo.CreateReadStream())
            {
                using (var streamReader = new StreamReader(stream, encoding, true))
                {
                    return streamReader.ReadToEnd();
                }
            }
        }

        /// <summary>
        /// Reads file content as string using the given <paramref name="encoding"/>.
        /// </summary>
        public static async Task<string> ReadAsStringAsync([NotNull] this IFileInfo fileInfo, Encoding encoding)
        {
            Check.NotNull(fileInfo, nameof(fileInfo));

            using (var stream = fileInfo.CreateReadStream())
            {
                using (var streamReader = new StreamReader(stream, encoding, true))
                {
                    return await streamReader.ReadToEndAsync();
                }
            }
        }

        /// <summary>
        /// Reads file content as byte[].
        /// </summary>
        public static byte[] ReadBytes([NotNull] this IFileInfo fileInfo)
        {
            Check.NotNull(fileInfo, nameof(fileInfo));

            using (var stream = fileInfo.CreateReadStream())
            {
                return stream.GetAllBytes();
            }
        }

        /// <summary>
        /// Reads file content as byte[].
        /// </summary>
        public static async Task<byte[]> ReadBytesAsync([NotNull] this IFileInfo fileInfo)
        {
            Check.NotNull(fileInfo, nameof(fileInfo));

            using (var stream = fileInfo.CreateReadStream())
            {
                return await stream.GetAllBytesAsync();
            }
        }

        public static string GetVirtualOrPhysicalPathOrNull([NotNull] this IFileInfo fileInfo)
        {
            Check.NotNull(fileInfo, nameof(fileInfo));

            if (fileInfo is EmbeddedResourceFileInfo embeddedFileInfo)
            {
                return embeddedFileInfo.VirtualPath;
            }

            if (fileInfo is InMemoryFileInfo inMemoryFileInfo)
            {
                return inMemoryFileInfo.DynamicPath;
            }

            return fileInfo.PhysicalPath;
        }
    }
}
