require('dotenv').config();
var mysql = require('mysql')

var pool = mysql.createPool({
  connectionLimit:10,
  host     : process.env.DBHOST,
  user     : process.env.DBUSER,
  password : process.env.PASS,
  database: process.env.DBNAME
});


function query(sql,params=[],callback, req=""){
    pool.query(sql,params,(error,results)=>{
      if(callback) callback(error,results);
    })
}


module.exports= {query}