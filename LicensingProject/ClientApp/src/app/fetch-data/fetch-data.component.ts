import { ChangeDetectorRef, Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { OnInit, OnDestroy } from '@angular/core';
import { Observable, Subscription } from 'rxjs';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent implements OnInit, OnDestroy{
  
  public forecasts!: Observable<WeatherForecast[]>;


  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private changeDetectorRef: ChangeDetectorRef) {
    
    
    }
  ngOnDestroy(): void {
    
  }

  ngOnInit(): void {
    this.forecasts = this.http.get<WeatherForecast[]>(this.baseUrl + 'weatherforecast');
  }
}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
