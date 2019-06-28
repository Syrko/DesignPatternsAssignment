using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace ServiceLayer
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class TableGateWay
    {
        //Dummy Class for TableGateWay Framework Zend\Db\TableGateway\TableGateway of PHP

        //Dummy Methods for select()
        public DataSet select()
        {
            return new DataSet();
        }
        public DataRow select(Dictionary<String, int> array)
        {
            return null;
        }

        public void insert(Dictionary<String, String> data)
        {
            //Dummy Insert Method
        }

        public void update(Dictionary<String, String> data, Dictionary<String, int> array)
        {
            //Dummy Update Method
        }
        public void delete(Dictionary<String, int> array)
        {
            //Dummy Insert Method
        }
    }

    class Album
    {
        public string artist;
        public string title;
        public int id;
    }

    class AlbumTable
    {
        protected TableGateWay tableGateway;

        public AlbumTable(TableGateWay tableGateWay)
        {
            this.tableGateway = tableGateway;
        }

        public void fetchAll()
        {
            DataSet results = new DataSet();
            results = tableGateway.select();
        }

        public DataRow getAlbum(int id)
        {
            Dictionary<String, int> array = new Dictionary<string, int>();
            DataRow row;
            List<DataRow> rowset = new List<DataRow>();
            array.Add("id", id);
            rowset.Add(tableGateway.select(array));
            row = rowset[id];
            if (row == null)
            {
                throw new Exception("Could not find row" + id);
            }
            return row;
        }

        public void saveAlbum(Album album)
        {
            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("artist", album.artist);
            data.Add("title", album.title);

            int id = album.id;
            if (id == 0)
            {
                tableGateway.insert(data);
            }
            else
            {
                if (!getAlbum(id).Equals(null))
                {
                    Dictionary<String, int> array = new Dictionary<string, int>();
                    array.Add("id", id);
                    tableGateway.update(data, array);
                }
                else
                {
                    throw new Exception("Form" + id + "does not exist");
                }
            }
        }

        public void deleteAlbum(int id)
        {
            Dictionary<String, int> array = new Dictionary<string, int>();
            array.Add("id", id);
            tableGateway.delete(array);
        }
    }
}
