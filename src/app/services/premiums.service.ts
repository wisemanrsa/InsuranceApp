import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { InsuredValueInterface } from '../models/insured-values.interface';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PremiumsService {

  constructor(private http: HttpClient) { }

  getInsuredValues(): Observable<InsuredValueInterface[]> {
    return this.http.get<InsuredValueInterface[]>('api/insuredValues');
  }
}
