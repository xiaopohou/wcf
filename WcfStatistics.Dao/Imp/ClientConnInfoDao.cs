//==============================================================================
//	CAUTION: This file is generated by IBatisNetGen.DaoImpl.cst at 2013/8/2 17:13:38
//				Any manual editing will be lost in re-generation.
//==============================================================================
using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using WcfStatistics.Model;
using WcfStatistics.Dao.Int;

namespace WcfStatistics.Dao.Imp {
	
    /// <summary><c>ClientConnInfoDao</c> is the implementation of <see cref="IClientConnInfoDao"/>.</summary>
    public partial class ClientConnInfoDao : BaseDao, IClientConnInfoDao {

		/// <summary>Implements <see cref="IClientConnInfoDao.GetCount"/></summary>
		public int GetCount() {
			String stmtId = "ClientConnInfo-GetCount";
			int result = Instance.QueryForObject<int>(stmtId, null);
			return result;
		}

		/// <summary>Implements <see cref="IClientConnInfoDao.Find"/></summary>
		public ClientConnInfo Find(Int64 iD) {
			String stmtId = "ClientConnInfo-Find";
			ClientConnInfo result = Instance.QueryForObject<ClientConnInfo>(stmtId, iD);
			return result;
		}

		/// <summary>Implements <see cref="IClientConnInfoDao.FindAll"/></summary>
		public IList<ClientConnInfo> FindAll() {
			String stmtId = "ClientConnInfo-FindAll";
			IList<ClientConnInfo> result = Instance.QueryForList<ClientConnInfo>(stmtId, null);
			return result;
		}
		
		/// <summary>Implements <see cref="IClientConnInfoDao.QuickFindAll"/></summary>
		public IList<ClientConnInfo> QuickFindAll() {
			String stmtId = "ClientConnInfo-QuickFindAll";
			IList<ClientConnInfo> result = Instance.QueryForList<ClientConnInfo>(stmtId, null);
			return result;
		}
		
		/// <summary>Implements <see cref="IClientConnInfoDao.FindByServerID"/></summary>
		public IList<ClientConnInfo> FindByServerID(Int32? serverID) {
			String stmtId = "ClientConnInfo-FindByServerID";
			IList<ClientConnInfo> result = Instance.QueryForList<ClientConnInfo>(stmtId, serverID);
			return result;
		}
		
		/// <summary>Implements <see cref="IClientConnInfoDao.FindByBatchID"/></summary>
		public IList<ClientConnInfo> FindByBatchID(Int32? batchID) {
			String stmtId = "ClientConnInfo-FindByBatchID";
			IList<ClientConnInfo> result = Instance.QueryForList<ClientConnInfo>(stmtId, batchID);
			return result;
		}
		
		/// <summary>Implements <see cref="IClientConnInfoDao.FindByIP"/></summary>
		public IList<ClientConnInfo> FindByIP(String iP) {
			String stmtId = "ClientConnInfo-FindByIP";
			IList<ClientConnInfo> result = Instance.QueryForList<ClientConnInfo>(stmtId, iP);
			return result;
		}
		
		/// <summary>Implements <see cref="IClientConnInfoDao.FindByAdress"/></summary>
		public IList<ClientConnInfo> FindByAdress(String adress) {
			String stmtId = "ClientConnInfo-FindByAdress";
			IList<ClientConnInfo> result = Instance.QueryForList<ClientConnInfo>(stmtId, adress);
			return result;
		}
		
		/// <summary>Implements <see cref="IClientConnInfoDao.FindByLinkNums"/></summary>
		public IList<ClientConnInfo> FindByLinkNums(Int32? linkNums) {
			String stmtId = "ClientConnInfo-FindByLinkNums";
			IList<ClientConnInfo> result = Instance.QueryForList<ClientConnInfo>(stmtId, linkNums);
			return result;
		}
		
		/// <summary>Implements <see cref="IClientConnInfoDao.Insert"/></summary>
		public void Insert(ClientConnInfo obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "ClientConnInfo-Insert";
			Instance.Insert(stmtId, obj);
		}
		
		/// <summary>Implements <see cref="IClientConnInfoDao.Update"/></summary>
		public void Update(ClientConnInfo obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "ClientConnInfo-Update";
			Instance.Update(stmtId, obj);
		}
		
		/// <summary>Implements <see cref="IClientConnInfoDao.Delete"/></summary>
		public void Delete(ClientConnInfo obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "ClientConnInfo-Delete";
			Instance.Delete(stmtId, obj);
		}
		
		/// <summary>Implements <see cref="IClientConnInfoDao.DeleteByServerID"/></summary>
		public int DeleteByServerID(Int32? serverID) {
			String stmtId = "ClientConnInfo-DeleteByServerID";
			int result = Instance.Delete(stmtId, serverID);
			return result;
		}
		
		/// <summary>Implements <see cref="IClientConnInfoDao.DeleteByBatchID"/></summary>
		public int DeleteByBatchID(Int32? batchID) {
			String stmtId = "ClientConnInfo-DeleteByBatchID";
			int result = Instance.Delete(stmtId, batchID);
			return result;
		}
		
		/// <summary>Implements <see cref="IClientConnInfoDao.DeleteByIP"/></summary>
		public int DeleteByIP(String iP) {
			String stmtId = "ClientConnInfo-DeleteByIP";
			int result = Instance.Delete(stmtId, iP);
			return result;
		}
		
		/// <summary>Implements <see cref="IClientConnInfoDao.DeleteByAdress"/></summary>
		public int DeleteByAdress(String adress) {
			String stmtId = "ClientConnInfo-DeleteByAdress";
			int result = Instance.Delete(stmtId, adress);
			return result;
		}
		
		/// <summary>Implements <see cref="IClientConnInfoDao.DeleteByLinkNums"/></summary>
		public int DeleteByLinkNums(Int32? linkNums) {
			String stmtId = "ClientConnInfo-DeleteByLinkNums";
			int result = Instance.Delete(stmtId, linkNums);
			return result;
		}
		
		/// <summary>Implements <see cref="IClientConnInfoDao.Reload"/></summary>
		public void Reload(ClientConnInfo obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "ClientConnInfo-Find";
			Instance.QueryForObject<ClientConnInfo>(stmtId, obj, obj);
		}
		
	}

}