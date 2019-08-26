using System.Collections.Generic;

namespace Corsinvest.ProxmoxVE.Api.Extension.Storage
{
    /// <summary>
    /// Client extension for sotrage
    /// </summary>
    public static class ClientExtension
    {
        /// <summary>
        /// Get all astorage client.
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static IReadOnlyList<StorageInfo> GetStorages(this Client client)
        {
            var storages = new List<StorageInfo>();
            foreach (var apiData in client.Storage.GetRest().Response.data)
            {
                switch (apiData.type)
                {
                    case "rbd": storages.Add(new Rbd(client, apiData)); break;
                    case "dir": storages.Add(new Dir(client, apiData)); break;
                    case "nfs": storages.Add(new NFS(client, apiData)); break;
                    case "zfs": storages.Add(new ZFS(client, apiData)); break;

                    // cephfs cifs drbd glusterfs iscsi 
                    // iscsidirect lvm lvmthin zfspool

                    default: storages.Add(new Unknown(client, apiData)); break;
                }
            }
            return storages.AsReadOnly();
        }
    }
}