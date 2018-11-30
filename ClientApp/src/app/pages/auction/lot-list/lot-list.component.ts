import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-lot-list',
  templateUrl: './lot-list.component.html',
  styleUrls: ['./lot-list.component.scss']
})
export class LotListComponent implements OnInit {
  @Input() lots;
  constructor() { }

  ngOnInit() {
  }

}
