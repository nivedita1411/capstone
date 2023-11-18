import { Component, OnInit } from '@angular/core';
import { Idetails } from '../model/idetail';
import { MovieserviceService } from '../services/movieservice.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-createdetails',
  templateUrl: './createdetails.component.html',
  styleUrls: ['./createdetails.component.css']
})
export class CreatedetailsComponent implements OnInit {
  detailsdata: Idetails = {detailid:0, Actor:'', MovieId:0, Gender:'',Role: ''}
  showdata: any[] = []

  constructor(private ms: MovieserviceService, private router: Router) { }

  savedata(data : Idetails):void{
    this.detailsdata = data 
    this.ms.addDetails(this.detailsdata).subscribe(
      ()=> {
        alert('Record Added Successfully')
        this.router.navigate(['/listmovies'])
      }
    )
  }
  
  
  

  ngOnInit() {
    this.ms.getAllMovies().subscribe(data => {this.showdata.push(...data) })
  }

}
