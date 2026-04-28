import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient) { }


  //plants
  getPlants(){
    return this.http.get("http://localhost:3000/api/plants")
  }
  getPlantsById(id:number){
    return this.http.get(`http://localhost:3000/api/plants/${id}`)
  }
  insertPlant(data:object){
    return this.http.post("http://localhost:3000/api/plants", data)
  }
  updatePlant(id:number,data:object){
    return this.http.patch(`http://localhost:3000/api/plants/${id}`,data)
  }
  deletePlant(id:number){
    return this.http.delete(`http://localhost:3000/api/plants/${id}`)
  }

  //Stats
  getStats(){
    return this.http.get("http://localhost:3000/api/plants/stats")
  }

  //Waterings
  getWateringsByPlantId(id:number){
    return this.http.get(`http://localhost:3000/api/plants/${id}/waterings`)
  }
  insertWatering(data:object){
    return this.http.post("http://localhost:3000/api/waterings", data)
  }
  deleteWatering(id:number){
    return this.http.delete(`http://localhost:3000/api/waterings/${id}`)
  }



}
