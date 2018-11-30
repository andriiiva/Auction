import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-lot-page',
  templateUrl: './lot-page.component.html',
  styleUrls: ['./lot-page.component.scss']
})
export class LotPageComponent implements OnInit {
  public id: number;
  constructor(private route: ActivatedRoute) { }

  ngOnInit() {
    this.id = +this.route.snapshot.paramMap.get('id');
  }
}
