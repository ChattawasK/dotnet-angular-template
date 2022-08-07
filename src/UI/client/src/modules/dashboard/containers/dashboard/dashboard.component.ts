import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { LeaveTypeService } from '@shared/services/leave-type.service';

@Component({
    selector: 'dashboard',

    templateUrl: './dashboard.component.html',
    styleUrls: ['dashboard.component.scss'],
})
export class DashboardComponent implements OnInit {
    data: any;
    constructor(private leaveTypeService: LeaveTypeService) {}
    ngOnInit() {
      this.leaveTypeService.getAll().subscribe((res: any) => {
        this.data = res;
      });

    }
}
