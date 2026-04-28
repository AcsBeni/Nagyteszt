import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { ApiService } from '../../service/api.service';
import { Plants } from '../../interfaces/plants';

@Component({
  selector: 'app-plants',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './plants.component.html',
  styleUrl: './plants.component.scss'
})
export class PlantsComponent implements OnInit {

  constructor(private api:ApiService){}

  plants:Plants[]=[]
  ngOnInit(): void {
    this.api.getPlants().subscribe({
     next: (res) => {
        console.log(res)
      },
      error: (err)=>{
        console.log(err)
      }
    })
  }
  
}
