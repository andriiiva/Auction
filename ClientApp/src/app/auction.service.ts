import { Injectable, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Lot } from './shared/lot.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuctionService {
  constructor(private http: HttpClient) { }

  getLots(): Observable<Lot[]> {
     return this.http.get<Lot[]>("api/auction");
  }
}