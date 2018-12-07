import { Injectable, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Lot } from './shared/lot.model';
import { Bid } from './shared/bid.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuctionService {
  constructor(private http: HttpClient) { }

  getLots(): Observable<Lot[]> {
     return this.http.get<Lot[]>("api/auction");
  }

  getLot(id): Observable<Lot[]> {
    return this.http.get<Lot[]>("api/auction/lot/" + id);
 }

  addLot(lot): Observable<Lot> {
    return this.http.post<Lot>("api/auction", lot);
  }

  addBid(bid): Observable<Bid> {
    return this.http.post<Bid>("api/auction/lot", bid);
  }

}
