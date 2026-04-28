const express = require('express');
const router = express.Router();
const {query} = require('../utils/database');

// insert watering
router.post("/", (req, res)=>{

    let {plant_id,date_watered,amount_ml,notes} = req.body;

    query("INSERT INTO `watering_logs`( `plant_id`, `date_watered`, `amount_ml`,`notes`) VALUES (?,?,?,?)",[plant_id,date_watered,amount_ml,notes], (error, results) =>{
        if(error) return res.status(500).json({errno: error, msg: "Hiba"}) ;
      
        res.status(200).json(results)
    },req);
});

// Delete watering by id
router.delete("/:id", (req, res)=>{
    let id = req.params.id
  
    query('DELETE FROM `watering_logs` WHERE id=?',[id], (error, results) =>{
        if(error) return res.status(500).json({errno: error, msg: "Hiba"}) ;
      
        res.status(200).json(results)
    },req);
});
module.exports= router;