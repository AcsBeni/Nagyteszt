const express = require('express');
const router = express.Router();
const {query} = require('../utils/database');

// Select all
router.get("/", (req, res)=>{
    query('SELECT * FROM plants',[], (error, results) =>{
        if(error) return res.status(500).json({errno: error, msg: "Hiba"}) ;
      
        res.status(200).json(results)
    },req);
});

// Select one by id
router.get("/:id", (req, res)=>{
    let id = req.params.id
    query('SELECT * FROM plants WHERE id=?',[id], (error, results) =>{
        if(error) return res.status(500).json({errno: error, msg: "Hiba"}) ;
      
        res.status(200).json(results)
    },req);
});
// insert plant
router.post("/", (req, res)=>{

    let {name, species, water_interval_days} = req.body;

    query("INSERT INTO `plants`(`name`, `species`, `water_interval_days`) VALUES (?,?,?)",[name, species, water_interval_days], (error, results) =>{
        if(error) return res.status(500).json({errno: error, msg: "Hiba"}) ;
      
        res.status(200).json(results)
    },req);
});
// Select one by id
router.patch("/:id", (req, res)=>{
    let id = req.params.id
    let {name, species, water_interval_days} = req.body;
    query('UPDATE `plants` SET `name`=?,`species`=?,`water_interval_days`=? WHERE id =?',[name, species, water_interval_days,id], (error, results) =>{
        if(error) return res.status(500).json({errno: error, msg: "Hiba"}) ;
      
        res.status(200).json(results)
    },req);
});
// Delete plant by id
router.delete("/:id", (req, res)=>{
    let id = req.params.id
  
    query('DELETE FROM `plants` WHERE id=?',[id], (error, results) =>{
        if(error) return res.status(500).json({errno: error, msg: "Hiba"}) ;
      
        res.status(200).json(results)
    },req);
});

// WATERING----------------------------------------------------------

// Select one by id
router.get("/:id/watering", (req, res)=>{
    let id = req.params.id
    query('SELECT * FROM watering_logs WHERE plant_id=?',[id], (error, results) =>{
        if(error) return res.status(500).json({errno: error, msg: "Hiba"}) ;
      
        res.status(200).json(results)
    },req);
});
// STATS-------------------------------------
// Select all stats
router.get("/", (req, res)=>{
    query('SELECT * FROM statistics',[], (error, results) =>{
        if(error) return res.status(500).json({errno: error.errno, msg: "Hiba"}) ;
      
        res.status(200).json(results)
    },req);
});



module.exports= router;