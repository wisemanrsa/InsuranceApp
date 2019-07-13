import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { InsuredValueInterface } from '../models/insured-values.interface';
import { Observable } from 'rxjs';
import { OldPremium } from '../models/old-premium';

@Injectable({
  providedIn: 'root'
})
export class PremiumsService {

  constructor(private http: HttpClient) { }

  getInsuredValues(): Observable<InsuredValueInterface[]> {
    return this.http.get<InsuredValueInterface[]>('api/insured-values');
  }

  calculatePremium(obj) {
    return this.http.post('api/premium', obj);
  }

  getHistory(): Observable<OldPremium[]> {
    return this.http.get<OldPremium[]>('/api/premium');
  }
}
