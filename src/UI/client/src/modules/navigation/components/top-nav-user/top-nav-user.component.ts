import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { UserService } from '@shared/services/user.service';

@Component({
    selector: 'top-nav-user',

    templateUrl: './top-nav-user.component.html',
    styleUrls: ['top-nav-user.component.scss'],
})
export class TopNavUserComponent implements OnInit {
    constructor(public userService: UserService) {}
    ngOnInit() {}
}
