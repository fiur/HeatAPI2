/**
 *  Copyright (c) 2014-Present, Facebook, Inc.
 *  All rights reserved.
 *
 *  This source code is licensed under the BSD-style license found in the
 *  LICENSE file in the root directory of this source tree. An additional grant
 *  of patent rights can be found in the PATENTS file in the same directory.
 */

import React from 'react';
import PropTypes from 'prop-types';
import * as Reactstrap from 'reactstrap';

export function CommentsBox(props) {
	let [state, updateState] = React.useState({
		measurerments: props.initialComments,
		page: props.page,
		loadingMore: false,
	});

	function loadMoreClicked(evt) {
		let nextPage = state.page + 1;
		let measurerments = state.measurerments;
		updateState(prevState => ({
			...prevState,
			page: nextPage,
			loadingMore: true,
		}));

		let url = '/api/Get/tinde/' + (state.page);
		let xhr = new XMLHttpRequest();
		xhr.open('GET', url, true);
		xhr.setRequestHeader('Content-Type', 'application/json');

		xhr.onload = () => {
			let data = JSON.parse(xhr.responseText);
			updateState(prevState => ({
				...prevState,
				measurerments: data,
				loadingMore: false,
			}));
		};
		xhr.send();
		evt.preventDefault();
	}


	let measurerments = state.measurerments.map((measurerment, index) => (
		<Measurerment key={measurerment.id} name={measurerment.name || "Intet Navn"} datetime={measurerment.datetime || "No Date"} value={measurerment.value || "Ingen Værdi"}></Measurerment>
	));


	function renderMoreLink() {
		if (state.loadingMore) {
			return <em>Loading...</em>;
		} else {
			return (
				<Reactstrap.Button onClick={loadMoreClicked}>Load Measurerment</Reactstrap.Button>
			);
		}
	}

	// This is an example of ReactJS.NET's server-side rendering. The initial state of this measurerments box is rendered server - side, and additional data is loaded via AJAX and rendered client - side.
	return (
		<div>
			<div className="measurerments">
				<h1>Measurerments</h1>
				<ol className="commentList" key="">{measurerments}</ol>
				{renderMoreLink()}
				<hr />
			</div>
		</div>
	);
}


class Measurerment extends React.Component {

	static propTypes = {
		id: PropTypes.string,
		name: PropTypes.string,
		value: PropTypes.string,
		datetime: PropTypes.string,
	};


	render() {

		return (
			<li>
				Klokken {this.props.datetime} var {this.props.name}: <strong> {this.props.value} </strong>
			</li>
		);
	}
}

