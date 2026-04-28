const express = require('express');
const cors = require('cors')

const plants = require('./modules/plants')
const waterings = require('./modules/watering')

const app = express();

app.use(cors());
app.use(express.json());
app.use(express.urlencoded({extended:true}));

app.use(cors({
  origin: 'http://localhost:4200'
}));

app.use("/api/plants",plants);
app.use("/api/watering",waterings)


app.listen(3000, ()=>{
     console.log(`App is listening on ${process.env.PORT}`)
})