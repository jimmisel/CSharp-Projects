namespace CustomerFeedback.Services {
    export class FeedbackService {
        private feedBackSource;

        public listFeedback() {
            return this.feedBackSource.query();
        }

        public save(feedBack) {
            return this.feedBackSource.save(feedBack).$promise;
        }

        public getFeedBack(id) {
            return this.feedBackSource.get({ id: id });
        }

        public deleteFeedBack(id) {
            return this.feedBackSource.delete({ id: id }).$promise;
        }

        constructor($resource: ng.resource.IResourceService) {
            this.feedBackSource = $resource('/api/Feedback/:id');
        }
    }

    angular.module('CustomerFeedback').service('feedbackService',FeedbackService)
    }
